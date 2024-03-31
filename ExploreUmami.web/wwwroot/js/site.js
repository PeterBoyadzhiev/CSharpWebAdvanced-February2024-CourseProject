document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('#map-container svg path').forEach(function (el) {
        
        el.addEventListener('click', function (path) {
            const elValue = path.target.attributes.title.value;
            const prefecture = elValue;
            document.location.href = `/Business/AllByPrefecture/${prefecture}`;
        })
    }) 
})