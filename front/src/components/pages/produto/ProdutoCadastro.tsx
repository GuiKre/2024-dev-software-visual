import React, { useState } from 'react';
import { Produto } from "../../../models/Produto";

function ProdutoCadastro() {
    const [nome, setNome] = useState<string>('');
    const [descricao, setDescricao] = useState<string>('');
    const [preco, setPreco] = useState<number>(0);
    const [quantidade, setQuantidade] = useState<number>(0);

    function enviarProduto (e: any) {
        e.preventDefault();

        const produto : Produto = {
            nome : nome,
            descricao : descricao,
            quantidade : quantidade,
            preco : preco
        };

        fetch("http://localhost:5178/produto/cadastrar", 
            {
                method : "POST",
                headers : {
                    "Content-Type" : "application/json"
                },
                body : JSON.stringify(produto)
            })
            .then(resposta => {
                return resposta.json();
            })
            .then(produto => {
                console.log("Produto cadastrado", produto)  
            })
    };

    return (
        <div id="cadastrar_produto">
            <h2>Cadastrar Novo Produto</h2>
            <form onSubmit={enviarProduto}>
                {/* <div>
                    <label htmlFor="nome">Nome</label>
                    <input type="text" id="nome" name="nome"
                        onChange={(e: any) => setNome(e.target.value)}/>
                </div> */}
                <label>
                    Nome:
                    <input type="string" value={nome} onChange={e => setNome(e.target.value)} required />
                </label>
                <label>
                    Descrição:
                    <input type="string" value={descricao} onChange={e => setDescricao(e.target.value)} required />
                </label>
                <label>
                    Preço:
                    <input type="number" value={preco} onChange={e => setPreco(Number(e.target.value))} required />
                </label>
                <label>
                    Quantidade:
                    <input type="number" value={quantidade} onChange={e => setQuantidade(Number(e.target.value))} required />
                </label>
                <button type="submit">Cadastrar</button>
            </form>
        </div>
    );
};

export default ProdutoCadastro;