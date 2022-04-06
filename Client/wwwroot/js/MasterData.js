$(document).ready(function () {
    $('#TableData').DataTable({
        "filter": true,
        "orderMulti": false,
        "ajax": {
            "url": "https://localhost:44351/api/Accounts/MasterData",
            "datatype": "json",
            "dataSrc": ""
        },
        "columns": [
            {
                "data": null,
                "name": "no",
                "autoWidth": true,
                "render": function (data, type, row, meta) {
                    return "";
                }
            },
            { "data": 'fullName' },
            { "data": 'phone' },
            { "data": 'salary' },
            { "data": 'gender' },
            { "data": 'birthdate' },
            { "data": 'roleName[].roleName' },

        ]
    });
});
$.ajax({
    url: "https://localhost:44351/api/Accounts/MasterData",
    success: function (result) {
        console.log(result);
    }
})