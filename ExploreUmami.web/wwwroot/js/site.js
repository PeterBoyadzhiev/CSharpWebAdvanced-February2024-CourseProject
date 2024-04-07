document.addEventListener('DOMContentLoaded', function () {
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
})

