function abrir(){
    document.getElementById('formulario').style.display = 'block'
    document.getElementById('content').style.filter = 'sepia(50%)'
}

function cerrar(){
    document.getElementById('formulario').style.display = 'none'
    document.getElementById('content').style.filter = 'sepia(0%)'
}

cerrar();