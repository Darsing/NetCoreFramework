function insertAutore() {
    var body = {};
    body.Nome = $('#nameAutore').val();
    $.ajax({
        method: "POST",
        url: "/api/Autore/InsertAutore",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(body),
        dataType: "json",
        success: function (data, status) {
            console.log(body);
            console.log(data);
            console.log(status);
            this.always();
        },
        error: function (error, status) {
            console.log(body);
            console.log(error);
            console.log(status);
            this.always();
        },
        always: function () { }
    });
};

function getAutore() {
    $.ajax({
        method: "GET",
        url: "/api/Autore/GetAutore",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data, status) {
            console.log(data);
            for (var i = 0; i < data.result.length; i++) {
                $("#resultAutore").append("<br/><div>" + " " + data.result[i].nome + "</div>");
            }
            this.always();
        },
        error: function (error, status) {
            console.log(error);
            console.log(status);
            this.always();
        },
        always: function () { }
    });
};

function insertLibro() {
    var body = {};
    body.Nome = $('#nameLibro').val();
    body.NumeroDiPagine = $('#numeroLibro').val();
    $.ajax({
        method: "POST",
        url: "/api/Libro/InsertLibro",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(body),
        dataType: "json",
        success: function (data, status) {
            console.log(body);
            console.log(data);
            console.log(status);
            this.always();
        },
        error: function (error, status) {
            console.log(body);
            console.log(error);
            console.log(status);
            this.always();
        },
        always: function () { }
    });
};

function getLibro() {
    $.ajax({
        method: "GET",
        url: "/api/Libro/GetLibro",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data, status) {
            console.log(data);
            for (var i = 0; i < data.result.length; i++) {
                $("#resultLibro").append("<br/><div>" + " " + data.result[i].nome + " " + data.result[i].numeroPagine +  "</div>");
            }
            this.always();
        },
        error: function (error, status) {
            console.log(error);
            console.log(status);
            this.always();
        },
        always: function () { }
    });
};