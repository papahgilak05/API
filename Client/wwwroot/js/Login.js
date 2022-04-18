function Login() {
    event.preventDefault();
    var obj = new Object();
    obj.Email = $('#LoginEmail').val();
    obj.Password = $('#LoginPassword').val();
    console.log(obj)
    $.ajax({
        url: "../Accounts/Login",
        type: "POST",
        data: obj,
    }).done((result) => {
        if (result.status == 200) {
            Swal.fire({
                title: 'Login Success',
                icon: 'success',
                text: result.message,
            }).then(function () {
                window.location.href = "Latihan/MasterData"
            })
        }
        else {
            Swal.fire({
                title: 'Login Error',
                icon: 'error',
                text: result.message,
            })
        }
        console.log(result)
    }).fail((error) => {
        console.log(error)
    })

    }