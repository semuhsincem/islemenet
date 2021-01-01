"use strict";
var KTDatatablesSearchOptionsAdvancedSearch = function() {

	$.fn.dataTable.Api.register('column().title()', function() {
		return $(this.header()).text().trim();
	});

	var initTable1 = function () {
		// begin first table
		var table = $('#kt_datatable').DataTable({
			responsive: true,
			// Pagination settings
			dom: `<'row'<'col-sm-12'tr>>
			<'row'<'col-sm-12 col-md-5'i><'col-sm-12 col-md-7 dataTables_pager'lp>>`,
			// read more: https://datatables.net/examples/basic_init/dom.html

			lengthMenu: [5, 10, 25, 50],

			pageLength: 10,

			language: {
				'lengthMenu': 'Display _MENU_',
			},

			searchDelay: 500,
			processing: true,
			serverSide: true,
			ajax: {
				url: "/RFQ/GetRFQList",
				type: 'POST',
				data: {
					// parameters for custom backend script demo
					columnsDef: [
						'title', 'delivaryDate', 'rfqDeadline','id'],
				},
			},
			columns: [
				{data: 'title'},
				{data: 'delivaryDate'},
				{ data: 'rfqDeadline'},
				{ data: 'id' },
			],

			initComplete: function() {
				//this.api().columns().every(function() {
				//	var column = this;

				//	switch (column.title()) {
				//		case 'Country':
				//			column.data().unique().sort().each(function(d, j) {
				//				$('.datatable-input[data-col-index="2"]').append('<option value="' + d + '">' + d + '</option>');
				//			});
				//			break;

				//		case 'Status':
				//			var status = {
				//				1: {'title': 'Pending', 'class': 'label-light-primary'},
				//				2: {'title': 'Delivered', 'class': ' label-light-danger'},
				//				3: {'title': 'Canceled', 'class': ' label-light-primary'},
				//				4: {'title': 'Success', 'class': ' label-light-success'},
				//				5: {'title': 'Info', 'class': ' label-light-info'},
				//				6: {'title': 'Danger', 'class': ' label-light-danger'},
				//				7: {'title': 'Warning', 'class': ' label-light-warning'},
				//			};
				//			column.data().unique().sort().each(function(d, j) {
				//				$('.datatable-input[data-col-index="6"]').append('<option value="' + d + '">' + status[d].title + '</option>');
				//			});
				//			break;

				//		case 'Type':
				//			var status = {
				//				1: {'title': 'Online', 'state': 'danger'},
				//				2: {'title': 'Retail', 'state': 'primary'},
				//				3: {'title': 'Direct', 'state': 'success'},
				//			};
				//			column.data().unique().sort().each(function(d, j) {
				//				$('.datatable-input[data-col-index="7"]').append('<option value="' + d + '">' + status[d].title + '</option>');
				//			});
				//			break;
				//	}
				//});
			},

			columnDefs: [
				{
					targets: 3,
					title: 'Actions',
					orderable: false,
					render: function(data, type, full, meta) {
						return  '<button class="btn btn-primary"><span class="far fa-eye"></span>&nbsp Show The RFQ</button>'
					},
				},
				{
					targets: 1,
					render: function (data, type, full, meta) {
						debugger;
						var d = new Date(data);
						return d.getDay() + "/" + d.getMonth()+"/" + d.getUTCFullYear();
					},
				},
				{
					targets: 2,
					render: function (data, type, full, meta) {
						debugger;
						var d = new Date(data);
						return d.getDay() + "/" + d.getMonth() + "/" + d.getUTCFullYear();
					},
				},
				//{
				//	targets: 7,
				//	render: function(data, type, full, meta) {
				//		var status = {
				//			1: {'title': 'Online', 'state': 'danger'},
				//			2: {'title': 'Retail', 'state': 'primary'},
				//			3: {'title': 'Direct', 'state': 'success'},
				//		};
				//		if (typeof status[data] === 'undefined') {
				//			return data;
				//		}
				//		return '<span class="label label-' + status[data].state + ' label-dot mr-2"></span>' +
				//			'<span class="font-weight-bold text-' + status[data].state + '">' + status[data].title + '</span>';
				//	},
				//},
			],
		});

		var filter = function() {
			var val = $.fn.dataTable.util.escapeRegex($(this).val());
			table.column($(this).data('col-index')).search(val ? val : '', false, false).draw();
		};

		 
		$('#kt_search').on('click', function(e) {
			e.preventDefault();
			var params = {};
			$('.datatable-input').each(function() {
				var i = $(this).data('col-index');
				if (params[i]) {
					params[i] += '|' + $(this).val();
				}
				else {
					params[i] = $(this).val();
				}
			});
			$.each(params, function(i, val) {
				// apply search params to datatable
				table.column(i).search(val ? val : '', false, false);
			});
			table.table().draw();
		});

		$('#kt_reset').on('click', function(e) {
			e.preventDefault();
			$('.datatable-input').each(function() {
				$(this).val('');
				table.column($(this).data('col-index')).search('', false, false);
			});
			table.table().draw();
		});

		$('#kt_datepicker').datepicker({
			todayHighlight: true,
			templates: {
				leftArrow: '<i class="la la-angle-left"></i>',
				rightArrow: '<i class="la la-angle-right"></i>',
			},
		});

	};

	return {

		//main function to initiate the module
		init: function() {
			initTable1();
		},

	};

}();

jQuery(document).ready(function() {
	KTDatatablesSearchOptionsAdvancedSearch.init();
});
