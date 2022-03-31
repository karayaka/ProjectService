
var myTable;

var categoryID = 0;

var categrys = [];

function drawDatable() {
    myTable= $('#myTable').DataTable({
       
        ajax: {
            "url": 'https://localhost:44376/categories',
            "type": "GET",
            "datatype": "json",
            "dataSrc": "",
        },
        columns: [
            { "data": "id" },
            { "data": "name" },
            { "data": "description" },
            {
                "data": "ID",
                "width": "10%",
                "render": function (data, type, row, meta) {
                    categrys.push(row);
                    return '<span class="dropdown">' +
                        '<button id="btnSearchDrop17" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true" class="btn btn-sm btn-primary dropdown-toggle dropdown-menu-right"><i class="la la-cog"></i></button>' +
                        '<span aria-labelledby="btnSearchDrop17" class="dropdown-menu mt-1 dropdown-menu-right">' +                        
                        '<a class="dropdown-item" onclick="deleteCategory(' + row.id + ')"><i class="la la-trash"></i> Sil</a>' +
                        '<a class="dropdown-item" onclick="editCategory(' + row.id + ')"><i class="la la-trash"></i> Düzenle</a>' +
                        '</span>' +
                        '</span>';
                },
            },
        ],
    });
}

function addCategory() {
    //var data = new FormData();

    
    var name = $('#name').val();
    var desc = $('#desc').val();

    var data = {
        id:0,
        name: name,
        description: desc,
    };

    $.ajax({
        url: "https://localhost:44376/categories",
        type: 'POST',
        async: false,
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(data),
        cache: false,
        processData: false,
        success: function (data2) {
            console.log(data2);
        },
        error: function (textStatus) {
            console.log(textStatus);
        },
    });

    myTable.ajax.reload();

}

function deleteCategory(ID) {

    $.ajax({
        url: "https://localhost:44376/categories/"+ID,
        type: 'DELETE',
        async: false,
        contentType: 'application/json; charset=utf-8',
        cache: false,
        processData: false,
        success: function (data2) {
            console.log(data2);
        },
        error: function (textStatus) {
            console.log(textStatus);
        },
    });

    myTable.ajax.reload();

}

function editCategory(ID) {
    categoryID = ID;
    var ctgr= categrys.filter((word) => word.id==ID)[0]
    $('#name').val(ctgr.name);
    $('#desc').val(ctgr.description);


}

function updateCategory() {
    var name = $('#name').val();
    var desc = $('#desc').val();

    var data = {
        id: categoryID,
        name: name,
        description: desc,
    };

    $.ajax({
        url: "https://localhost:44376/categories/" + categoryID,
        type: 'PUT',
        async: false,
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(data),
        cache: false,
        processData: false,
        success: function (data2) {
            console.log(data2);
        },
        error: function (textStatus) {
            console.log(textStatus);
        },
    });

    myTable.ajax.reload();
}

function cleanCategory() {

    categoryID = 0;
    $('#name').val("");
    $('#desc').val("");

}

function saveCategori() {

    if (categoryID == 0) {
        addCategory()
    } else {
        updateCategory();
    }

    
}