document.getElementById("fileopen").onchange = function () {
    document.getElementById("uploadFile").value = this.value;
};

$("#btnProcesar").click(function () {
    
    document.getElementById("uploadFile").value = "Seleccione un archivo XML";
});