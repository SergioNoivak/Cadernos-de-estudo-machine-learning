"use strict";
exports.__esModule = true;
var No = /** @class */ (function () {
    function No(nome) {
        if (nome === void 0) { nome = -1; }
        this.Adj = {};
        this.nome = nome;
        this.descoberto = false;
    }
    No.prototype.adicionarAresta = function (fim, peso) {
        if (!this.Adj[fim.nome])
            this.Adj[fim.nome] = peso;
    };
    return No;
}());
exports.No = No;
