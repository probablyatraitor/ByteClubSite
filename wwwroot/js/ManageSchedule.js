﻿var dataTable;

$(document).ready(function () {
	loadDataTable();
})

function loadDataTable() {
	dataTable = $('#DT_load').DataTable({
		"order": [[2, 'asc']],
		"ajax": {
			"url": "/api/agenda",
			"type": "GET",
			"datatype": "json"
		},
		"columns": [
			{ "data": "class", "width": "20%" },
			{
				"data": "body", "width": "50%", scrollY: 100,
				scroller: {
					rowHeight: 100
				},
				scrollX: true,
				scrollCollapse: true,
				paging: true
			},
			{
				"data": "id",
				"render": function (data) {
					return `<div class="text-center">
						<a href="/Screen/Edit?id=${data}" class="btn btn-success text-white" style="cursor:pointer; width:70px;">Edit</a>
						</div>`;
				}, "width": "30%"
			}
		],
		"language": {
			"emptyTables": "no data found"
		},
		"width": "100%"
	})
}