# Api de Juros SoftTax
# Autor: Gustavo Rosauro

Observação quando for iniciar o projeto existe uma dependencia entre as APIs, por meio da url a API CalculoSoft faz uma chamada para a API TaxaSoft.
então basta ir nesse caminho no projeto ./SoftTax/CalculoSoft/Communs/SoftRule.cs e colocar a URL aonde a API TaxaSoft esteja sendo executada 
URL NO DOCKER http://192.168.99.100:5001/taxajuros
URL NO DEBUG http://localhost:64071/taxajuros
