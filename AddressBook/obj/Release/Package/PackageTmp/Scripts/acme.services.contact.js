acme.services.contact = acme.services.contact || {};

acme.services.contact.getAll = function(onSuccess, onError){
	var url = '/api/contact';
	var settings = {
		cache: false,
		dataType: "json",
		success: onSuccess,
		error: onError,
		type: 'GET'
	};
	$.ajax(url, settings);
};

acme.services.contact.save = function (data, onSuccess, onError) {
	var url = '/api/contact';
	var settings = {
		cache: false,
		contentType: "application/x-www-form-urlencoded; charset=UTF-8",
		dataType:"json",
		type: 'POST',
		data: data,
		success: onSuccess,
		error: onError
	};
	$.ajax(url, settings);
};

acme.services.contact.update = function (data, onSuccess, onError) {
	var url = '/api/contact';
	var settings = {
		cache: false,
		contentType: "application/x-www-form-urlencoded; charset=UTF-8",
		dataType: "json",
		type: 'PUT',
		data: data,
		success: onSuccess,
		error: onError
	};
	$.ajax(url, settings);
};

acme.services.contact.delete = function (data, onSuccess, onError) {
	var url = '/api/contact?id=' + data;
	var settings = {
		cache: false,
		contentType: "application/x-www-form-urlencoded; charset=UTF-8",
		dataType: "json",
		type: 'DELETE',
		success: onSuccess,
		error: onError
	};
	$.ajax(url, settings);
};