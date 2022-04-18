$.fn.dataTable.ext.buttons.register = {
    text: 'register',
    action: function (e, dt, node, config) {

        $('#RegisterModal').modal()
    }
};

$(document).ready(function () {
    $('#TableData').DataTable({
        "filter": true,
        "orderMulti": false,
        "processing": true,
        "ajax": {
            /*"url": "https://localhost:44351/api/Accounts/MasterData",*/
            "url": "../Accounts/MasterData",
            "datatype": "json",
            "dataSrc": ""
        },
        "columns": [
            {
                "data": null,
                "name": "no",
                "autoWidth": true,
                "render": function (data, type, row, meta) {
                    return meta.row + 1;
                }
            },
            {
                "data": 'fullname',
                "autoWidth": true,
                /*"render": function (data, type, row, meta) {
                    return row['firstName'] + " " + row['lastName'];
                }*/
            },
            {
                "data": 'phone',
                "autoWidth": true,
                "render": function (data, type, row, meta) {
                    return "+62" + row["phone"].substr(1, 12);
                }
            },
            {
                "data": 'salary',

                "render": function (data, type, row, meta) {
                    return " RP. " + row["salary"];
                },
                "autoWidth": true
            },
            {
                "data": 'gender',
                "autoWidth": true,
                /*"render": function (data, type, row, meta) {
                    if (row['gender'] == 0) {
                        return "Male";
                    } else
                        return "Female";
                }*/
            },
            {
                "data": 'birthDate',
                "render": function (data, type, row) {
                    //var dateSplit = data.split('/');
                    //return type === "display" || type === "filter" ?
                        //dateSplit[1] + '/' + dateSplit[2].substr(0, 2) + '/' + dateSplit[0] :
                        //data;
                    var dateSplit = moment(data).format('LL');
                    return dateSplit;
                },
                "autoWidth": true
            },
            {
                "data": 'roleName[].roleName',
                "autoWidth": true
            },
            {
                "autoWidth": true,
                "orderable" : false,
                "render": function (data, type, row) {
                    return `<button onclick='Delete("${row["nik"]}")' class="btn btn-danger fa-solid fa-trash-can" data-toggle="tooltip" data-placement="top" title="Delete"></button>
                            <button data-toggle="modal" onclick='ReadUpdate("${row["nik"]}")' data-target='#UpdateModal' class="btn btn-primary fa-solid fa-pen-to-square" data-toggle="tooltip" data-placement="top" title="Update"></button>`;
                },
                
            }

        ],
        dom: 'lBfrtip',
        buttons: [
            'copy', 'excel', 'pdf', 'register',
        ]
    });
});

function Insert() {
    var obj = new Object(); // sesuaikan sendiri nama objectnya dan beserta isinya
    event.preventDefault();
    //ini mengambil value dari tiap inputan formnya
    obj.FirstName = $('#FirstName').val();
    obj.LastName = $('#LastName').val();
    obj.Phone = $('#Phone').val();
    obj.Birthdate = $('#Birthdate').val();
    obj.Salary = $('#Salary').val();
    obj.Email = $('#Email').val();
    obj.Gender = $('#Gender').val();
    obj.Password = $('#Password').val();
    obj.Degree = $('#Degree').val();
    obj.GPA = $('#GPA').val();
    obj.UniversitiesID = $('#UniversitiesID').val();
    console.log(obj);
    $.ajax({
        /*url: "https://localhost:44351/api/Accounts/Register",*/
        url : "../Accounts/Register",
        type: "POST",
        data: obj,
    }).done((result) => {
        console.log(result);
        Swal.fire({
            title: 'Regist Sukses',
            icon: 'success'
        })
    }).fail((error) => {
        console.log(error);
        Swal.fire({
            title: 'Regist Gagal',
            icon: 'error'
        })
    })
}

function Delete(NIK) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "DELETE",
                url: "https://localhost:44351/api/Employees/" + NIK,


            }).done((result) => {
            }).fail((error) => {
            })
            Swal.fire(
                'Deleted!',
                'Your file has been deleted.',
                'success'
            )
        }
    })
        }

function ReadUpdate(NIK) {
    $.ajax({
        url: "https://localhost:44351/api/Employees/" + NIK,
        /*url : "../Accounts/MasterData" + NIK, */
        success: function (results) {
            let result = results.result
            $('#NIKUpdate').attr(
                'value',
                `${result.nik}`)
            $('#FirstNameUpdate').attr(
                'value',
                `${result.firstName}`)
            $('#LastNameUpdate').attr(
                'value',
                `${result.lastName}`)
            $('#PhoneUpdate').attr(
                'value',
                `${result.phone}`)
            $('#BirthdateUpdate').attr(
                'value',
                `${result.birthDate}`.toString().substring(0,10))
            $('#SalaryUpdate').attr(
                'value',
                `${result.salary}`)
            $('#EmailUpdate').attr(
                'value',
                `${result.email}`)
            if (result.gender == 0) {
                $('#GenderUpdate').val("0")
            } else
                $('#GenderUpdate').val("1")

        }
    })
}
function Update() {
    var obj3 = new Object();
    event.preventDefault();
    obj3.NIK = $('#NIKUpdate').val();
    obj3.FirstName = $('#FirstNameUpdate').val();
    obj3.LastName = $('#LastNameUpdate').val();
    obj3.Phone = $('#PhoneUpdate').val();
    obj3.Birthdate = $('#BirthdateUpdate').val();
    obj3.Salary = $('#SalaryUpdate').val();
    obj3.Email = $('#EmailUpdate').val();
    obj3.Gender = $('#GenderUpdate').val();
    $.ajax({

        url: "https://localhost:44351/api/Employees/",
        /*url: "../Accounts/Update",*/
        type: "PUT",
        headers: {
            Accept: 'application/json',
            'Content-Type': 'application/json',
        },
        dataType: 'json',
        data: JSON.stringify(obj3),

    }).done((result) => {
        console.log(result);
        Swal.fire({
            title: 'Update Sukses',
            icon: 'success'
        })
    }).fail((error) => {
        console.log(error);
        Swal.fire({
            title: 'Update Gagal',
            icon: 'error'
        })
    })
    console.log(obj3);
}
$.ajax({

    /*url: "https://localhost:44351/api/Accounts/MasterData",*/
    url : "../Accounts/MasterData",
    success: function (result) {
        console.log(result);

        var male = 0;
        var female = 0;
        for (var i = 0; i < result.length; i++) {
            var sex = result[i].gender;

            if (sex == "Male")
                male += 1;
            else
                female += 1;
        }
        var options = {
            chart: {
                type: 'bar'
            },
            series: [{
                name: 'SEX',
                data: [male, female]
            }],
            xaxis: {
                categories: ['male', 'female']
            }
        }
        var chart = new ApexCharts(document.querySelector("#sexchart"), options);

        chart.render();
    }
})

$(document).ready(function () {
    const universities = (function () {
        var data = null

        $.ajax({
            async: false,
            type: 'GET',
            /*url: "https://localhost:44351/api/Universities"*/
            url:"../University/GetAll",
            data: {},
            success: function (response) {
                data = response;
            },
        })
        return data
    })()

    $.ajax({
        type: "GET",
        /*url: "https://localhost:44351/api/Accounts/MasterData",*/
        url : "../Accounts/MasterData",
        data: {},
    }).done((result) => {
        chartUniversity(result)
    }).fail((e) => {
        console.error(e)
        window.location.href = "../Handler"

    })

    const chartUniversity = (employees) => {
        console.log("employees", employees);
        const chartUniversity = universities.map((u) => {
            let count = 0

            if (employees !== undefined) {
                employees.forEach((emp) => {
                    if (u.name === emp.universityName) {
                        count += 1
                    }
                })
            }
            return { name: u.name, empNum: count }
        })
        console.log(chartUniversity);

        var options = {
            series: chartUniversity.map((universities) => universities.empNum),
            chart: {
                width: 580,
                type: 'pie',
                selection: {
                    enabled: true
                },
                toolbar: {
                    show:true,
                    tools: {
                        download:true,
                    },
                    offsetX: -7,
                    offsetY: 0,
                },
            },
            labels: chartUniversity.map((universities) => universities.name),
            responsive: [{
                breakpoint: 480,
                options: {
                    chart: {
                        width: 400
                    },
                    legend: {
                        position: 'bottom'
                    }
                }
            }]
        };

        var chart = new ApexCharts(document.querySelector("#unichart"), options);
        chart.render();

    }

})