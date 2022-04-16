function clicou() {
    fetch('https://localhost:5001/Woman/')
    .then(response => response.json())
    .then(data => {
        
        console.log(data);
        const linhaMensagem = document.getElementById("mensagemtxt");
        const linhaImagem = document.getElementById("imagem");
        linhaMensagem.textContent = data.frase + " - Autora: " + data.autora;
        linhaImagem.src = "fotos/"+data.foto;
         
        
    })
}
