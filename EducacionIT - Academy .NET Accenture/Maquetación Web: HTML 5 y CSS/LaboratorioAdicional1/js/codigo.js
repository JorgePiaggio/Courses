function abrir(){
    document.getElementById('formulario').style.display = 'block'
    document.getElementById('main-container').style.filter = 'grayscale(80%)'
    document.getElementsByTagName('body')[0].style.border = '.4em solid grey'
    document.getElementsByTagName('body')[0].style.backgroundColor = 'black'
}

function cerrar(){
    document.getElementById('formulario').style.display = 'none'
    document.getElementById('main-container').style.filter = 'grayscale(0%)'
    document.getElementsByTagName('body')[0].style.border = '.4em solid #3C2D58'
    document.getElementsByTagName('body')[0].style.backgroundColor = '#3C2D58'
}

cerrar();