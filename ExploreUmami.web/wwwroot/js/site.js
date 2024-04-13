document.addEventListener('DOMContentLoaded', async () => {

    const prefectureStore = {}

    document.querySelectorAll('#map-container svg path').forEach(function (el) {
        
        el.addEventListener('click', function (path) {
            const elValue = path.target.attributes.title.value;
            const prefecture = elValue;
            document.location.href = `/Business/ByPrefecture?name=${prefecture}`;
        })

        el.addEventListener('mouseover', async function (event) {
            const elValue = event.target.attributes.title.value;
            const prefecture = elValue;
            if (!prefectureStore.hasOwnProperty(prefecture)) {
                const info = await getPrefectureInfo(prefecture);
                prefectureStore[prefecture] = info;
                showInfoWindow(info);

            }
            else {
                showInfoWindow(prefectureStore[prefecture]);
            }
        })
    })

    async function getPrefectureInfo(prefecture) {
        try {
            const response = await fetch(`https://localhost:7110/api/Prefecture?prefectureName=${prefecture}`);

            if (response.ok) {
                const info = await response.json();
                return info;
            } else {
                console.error(`Error fetching prefecture info for ${prefecture}: ${response.statusText}`);
                return null;
            }
        } catch (error) {
            console.error(`Error fetching prefecture info for ${prefecture}`, error);
            return null;
        }
    }

    function showInfoWindow(info) {
        const prefectureName = document.querySelector('.prefecture-name');
        const businessCount = document.querySelector('.business-count');
        const businessImage = document.querySelector('.business-card .card-img-top');
        const businessTitle = document.querySelector('.business-card .card-title');
        const businessDescription = document.querySelector('.business-card .card-text');
        const hiddenElement = document.querySelector('#map-container .card-col.hidden');
        const cardElement = document.querySelector('.business-card .card');

        if (hiddenElement) {
            hiddenElement.classList.remove('hidden');
        }

        prefectureName.textContent = info.prefectureName;
        businessCount.textContent = `${info.businessCount} Businesses`;

        if (info.highestRatedBusiness) {
            cardElement.classList.remove("hidden")
            businessImage.src = info.highestRatedBusiness?.imageUrl;
            businessTitle.textContent = info.highestRatedBusiness?.title;
            businessDescription.textContent = info.highestRatedBusiness?.description;
        }
        else {
            cardElement.classList.add('hidden');
        }
        
    }

    $("#datetimepicker").flatpickr(
        {
            enableTime: true,
            minTime: "09:00",
            maxTime: "22:00",
            defaultDate: Date.now(),
        }
    );

    try {
        async function getIp() {
            const response = await fetch('https://api.ipify.org/?format=json');
            const data = await response.json();
            return data.ip;
        }

        const ip = await getIp();
        const response = await fetch(`https://api.ipgeolocation.io/ipgeo?apiKey=8e6ce2915e2e4089865ca6ee8a779914&ip=${ip}`)
        const data = await response.json();

        if (data) {
            const cookieValue = encodeURIComponent(`${data.city}, ${data.country_name}`);
            document.cookie = `location=${cookieValue}; path=/`
        }

    } catch (e) {
        console.log(e);
    }
})

