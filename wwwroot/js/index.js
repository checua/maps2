const _modeloEmpleado = {
    idEmpleado: 0,
    nombreCompleto: "",
    idDepartamento: 0,
    sueldo: 0,
    fechaContrato: ""
}
document.addEventListener("DOMContentLoaded", function () {

    //MostrarEmpleados();

    fetch("/Home/listaTipoPropiedades")
        .then(response => {
            return response.ok ? response.json() : Promise.reject(response)
        })
        .then(responseJson => {

            if (responseJson.length > 0) {
                responseJson.forEach((item) => {

                    $("#cboTipoPropiedad").append(
                        $("<option>").val(item.idTipoPropiedad).text(item.nombre)
                    )

                })
            }

        })

    //$("#txtFechaContrato").datepicker({
    //    format: "dd/mm/yyyy",
    //    autoclose: true,
    //    todayHighlight: true
    //})


}, false)



$(document).on("click", "btnModal", function () {

    //_modeloEmpleado.idEmpleado = 0;
    //_modeloEmpleado.nombreCompleto = "";
    //_modeloEmpleado.idDepartamento = 0;
    //_modeloEmpleado.sueldo = 0;
    //_modeloEmpleado.fechaContrato = "";

    //alert("Hola2");
    $("#exampleModal").modal("show");
    //MostrarModal();

})