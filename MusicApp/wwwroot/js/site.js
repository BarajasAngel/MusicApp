// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function submitAgregar() {    
    var txtTitulo = document.getElementById("txtTitulo");
    var txtGrupo = document.getElementById("txtGrupo");
    var txtAño = document.getElementById("txtAño");
    var txtGenero = document.getElementById("txtGenero");
    if (txtTitulo.value != "" && txtGrupo.value != "" &&
        txtAño.value != "" && txtGenero.value != "") {   
        
        if (txtAño.value.length == 4) {
            frmAgregar.submit();
        } else {
            document.getElementById("alert").innerHTML = `
                    <div class="alert alert-danger alert-dismissible fade show" role="alert" id="alert">
                        El año debe tener 4 caracteres.
                        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
                    </div>`;
        }
    } else {
        document.getElementById("alert").innerHTML = `
                    <div class="alert alert-danger alert-dismissible fade show" role="alert" id="alert">
                        Por favor rellena los campos necesarios.
                        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
                    </div>`;
    }
}
function submitEditar() {    
    var txtTitulo = document.getElementById("txtTituloE");
    var txtGrupo = document.getElementById("txtGrupoE");
    var txtAño = document.getElementById("txtAñoE");
    var txtGenero = document.getElementById("txtGeneroE");
    if (txtTitulo.value != "" && txtGrupo.value != "" &&
        txtAño.value != "" && txtGenero.value != "") {
        if (txtAño.length == 4) {
            frmEditar.submit();
        } else {
            document.getElementById("alertE").innerHTML = `
                    <div class="alert alert-danger alert-dismissible fade show" role="alert" id="alert">
                        El año debe tener 4 caracteres.
                        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
                    </div>`;
        }
    } else {
        document.getElementById("alertE").innerHTML = `
                    <div class="alert alert-danger alert-dismissible fade show" role="alert" id="alert">
                        Por favor rellena los campos necesarios.
                        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
                    </div>`;
    }
}

function submitEliminar(id) {
    document.getElementById("idCancion").value = id;
}

function confirmar() {
    frmEliminar.submit();
}