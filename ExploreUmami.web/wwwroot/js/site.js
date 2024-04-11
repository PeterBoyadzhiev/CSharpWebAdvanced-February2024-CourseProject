document.addEventListener('DOMContentLoaded', async () => {
    document.querySelectorAll('#map-container svg path').forEach(function (el) {
        
        el.addEventListener('click', function (path) {
            const elValue = path.target.attributes.title.value;
            const prefecture = elValue;
            document.location.href = `/Business/ByPrefecture?name=${prefecture}`;
        })
    })

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

