import { useEffect } from "react";

function ProdutoListar(){
    useEffect(() => {
        // Função utilizada para executar algum código ao abrir ou renderizar o componente
        // AXIOS biblioteca de requisições HTTP
        fetch("https://viacep.com.br/ws/82300160/json/")
            .then(resposta => {
                return resposta.json();
            })
            .then(cep => {
                console.log(cep);
            })

    });
    return (
        <div>        
            <h1>Primeiro Post!</h1>
            <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Vel quis nam consequuntur beatae asperiores suscipit placeat quas blanditiis, deleniti cupiditate rerum. Quis illum debitis accusantium fugiat autem veritatis hic eligendi?</p>
        </div>
    );
}

export default ProdutoListar;

// 1 - Exibir alguma informação do CEP no navegador
// 2 - Realizar a requisição para a sua API
// 3 - Resolver o problema de CORS que será mostrado no console
// 4 - Exibir a lista de produtos no navegador