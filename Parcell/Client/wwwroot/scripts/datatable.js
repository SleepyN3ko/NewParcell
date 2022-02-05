function AddDataTable(table) {
    $(document).ready(function () {
        $(table).DataTable({
            initComplete: function () {
                this.api().columns([2,3]).every(function () {
                    var column = this;
                    var select = $('<select><option value="">All</option></select>')
                        .appendTo($(column.header()))
                        .on('change', function () {
                            var val = $.fn.dataTable.util.escapeRegex(
                                $(this).val()
                            );

                            column
                                .search(val ? '^' + val + '$' : '', true, false)
                                .draw();
                        });
                    $(select).click(function (e) {
                        e.stopPropagation();
                    });
                    column.data().unique().sort().each(function (d, j) {
                        select.append('<option value="' + d + '">' + d + '</option>')
                    });
                });
            }
        });
    });
}
function DataTablesDispose(table) {
	$(document).ready(function () {
		$(table).DataTable().destroy();
		var element = document.querySelector(table + '_wrapper');
		element.parentNode.removeChild(element);
	})
}