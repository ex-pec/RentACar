$("form#LoginPost").submit(function (e) {
    e.preventDefault();
    let formData = new FormData(this);

    sendPostRequest(
        "../Account/Login", // ../Home/IndexJson
        formData, //or objectData
        true, //if formData send true, if onjectData send false
        this, // this not need for object but send will not be used
        "Başarılı",
        "error",
        false, //want to accept alert true or false
        true, //check validation for form true or false
        "../Home/Index" // redirect url if want to reload page send # or send "../Home/Index"
    );
});