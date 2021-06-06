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

  alert(ponto.descricao);
}

function main() {
  let data = fazGet("http://localhost:63876/api/pontos/listar");
  let pontos = JSON.parse(data);
  let tabela = document.getElementById("tabela");
  pontos.forEach((element) => {
    let linha = criaLinha(element);
    tabela.appendChild(linha);
  });
}

main();
