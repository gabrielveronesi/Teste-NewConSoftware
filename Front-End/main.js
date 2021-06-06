function fazGet(url) {
  let request = new XMLHttpRequest();
  request.open("GET", url, false);
  request.send();
  return request.responseText;
}

function criaLinha(usuario) {
  linha = document.createElement("tr");
  tdId = document.createElement("td");
  tdNome = document.createElement("td");
  tdLocalizacao = document.createElement("td");
  tdCidade = document.createElement("td");
  tdEstado = document.createElement("td");
  tdBotao = document.createElement("td");

  tdId.innerHTML = usuario.id;
  tdNome.innerHTML = usuario.nome;
  tdLocalizacao.innerHTML = usuario.localizacao;
  tdCidade.innerHTML = usuario.cidade;
  tdEstado.innerHTML = usuario.estado;
  tdBotao.innerHTML =
    '<button type="button" class="btn btn-outline-primary" onclick="chamaId(this)" ">Descrição</button>';

  linha.appendChild(tdId);
  linha.appendChild(tdNome);
  linha.appendChild(tdLocalizacao);
  linha.appendChild(tdCidade);
  linha.appendChild(tdEstado);
  linha.appendChild(tdBotao);

  return linha;
}

document.body.onload = chamaId;

function chamaId(r) {
  var i = r.parentNode.parentNode.rowIndex;
  i++;

  let data = fazGet("http://localhost:63876/api/pontos/" + i);
  let ponto = JSON.parse(data);

  alert(ponto.data.descricao);
}

function main() {
  let xdata = fazGet("http://localhost:63876/api/pontos/listar");
  console.log(xdata);
  let json = JSON.parse(xdata);
  console.log(json);
  console.log(json.data.pontos);


  let filtrado = json.data.pontos;


  let tabela = document.getElementById("tabela");
  json.data.pontos.forEach((element) => {
    let linha = criaLinha(element);
    tabela.appendChild(linha);
  });
}

main();
