"use client";
import Image from "next/image";
import { useState } from "react";
const Formulario = ({ itens, setItens }) => {
  const [tipo, setTipo] = useState("");
  const [descricao, setDescricao] = useState("");
  const [dtPagamento, setDtPagamento] = useState("");
  const [valorBruto, setValorBruto] = useState("");
  const [valorLiquido, setValorLiquido] = useState("");

  const handleChange = (event) => {
    // Voltar aqui
    const selectedValue = event.target.value;
    if (selectedValue === "1") {
      setTipo("Conta Fixa");
    } else if (selectedValue === "2") {
      setTipo("Cartão");
    }
  };
  return (
    <div className="flex flex-col">
      <label>Tipo de Conta</label>
      <select value={tipo} onChange={handleChange}>
        <option value="1">Conta Fixa</option>
        <option value="2">Cartão</option>
      </select>
      <div className="flex flex-col my-2">
        <label>Descrição</label>
        <input className="border" type="text" value={descricao} onChange={(e) => setDescricao(e.target.value)} />
      </div>
      <div className="flex flex-col my-2">
        <label>Data de Pagamento</label>
        <input className="border" type="date" value={dtPagamento} onChange={(e) => setDtPagamento(e.target.value)} />
      </div>
      <div className="flex flex-col my-2">
        <label>Valor Bruto</label>
        <input className="border" type="text" value={valorBruto} onChange={(e) => setValorBruto(e.target.value)} />
      </div>
      <div className="flex flex-col my-2">
        <label>Valor Liquido</label>
        <input className="border" type="text" value={valorLiquido} onChange={(e) => setValorLiquido(e.target.value)} />
      </div>
      <div className="flex flex-col my-2">
        <button
          className="px-3 py-2 bg-blue-500 rounded-full"
          onClick={() => {
            console.log(tipo, descricao, dtPagamento, valorBruto, valorLiquido);
            setItens([...itens, { tipo, descricao, dtPagamento, valorBruto, valorLiquido }]);
          }}>
          Salvar
        </button>
      </div>
    </div>
  );
};

export default function Home() {
  const [itens, setItens] = useState([{ tipo: "Conta Fixa", descricao: "Internet", dtPagamento: "07/12/2022", valorBruto: "R$ 89,90", valorLiquido: "R$ 89,99" }]);
  return (
    <div className="grid grid-rows-[20px_1fr_20px] items-center justify-items-center min-h-screen p-5 pb-20 gap-16 sm:p-20 font-[family-name:var(--font-geist-sans)]">
      <main className="flex flex-row w-5/6 gap-8 row-start-2 items-start ">
        <Formulario itens={itens} setItens={setItens} />
        <table className="">
          <th className="border px-3 text-center">Tipo</th>
          <th className="border px-3 text-center">Descrição</th>
          <th className="border px-3 text-center">Dt.Pagamento</th>
          <th className="border px-3 text-center">Valor Bruto</th>
          <th className="border px-3 text-center">Valor Liquido</th>
          <tbody>
            {itens.map((item) => (
              <tr>
                <td className="border px-3 text-center">{item.tipo}</td>
                <td className="border px-3 text-center">{item.descricao}</td>
                <td className="border px-3 text-center">{item.dtPagamento}</td>
                <td className="border px-3 text-center">{item.valorBruto}</td>
                <td className="border px-3 text-center">{item.valorLiquido}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </main>
      <footer className="row-start-3 flex gap-6 flex-wrap items-center justify-center">
        <p>Em desenvolvimento por mim :D</p>
      </footer>
    </div>
  );
}
