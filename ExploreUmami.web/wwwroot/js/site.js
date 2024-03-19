document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('#map-container svg path').forEach(function (el) {
        
        el.addEventListener('click', function (path) {
            const elValue = path.target.attributes.title.value;
            const country = elValue.toLowerCase();
            document.location.href = `/business/per-country/${country}`;
        })
    }) 
    })