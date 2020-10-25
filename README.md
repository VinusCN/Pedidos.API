# 📦 Pedidos API

Esse projeto é uma API de pedidos feita e ASP.NET Core e tem os seguintes endpoints:

- POST /pedidos – Cria um pedido.
- POST /pedidos/receber/{id} – Muda o status do pedido para "Recebido".
- GET /pedidos – Retorna todos os pedidos.

## 🛠️ Tecnologias Usadas

- ASP.NET Core
- SQL Server

## ⚙️ Executando a Aplicação

- Clonar o repostorio $ git clone https://github.com/VinusCN/Pedidos.API.git
- Mudar a "ConnectionStrings" no arquivo appsettings.json.
- No Package Manager Console rodar " Update-Database ", para criar o banco.