//=> Defne
$(document).on("click", "#exBtn", function () {//exbtn = id of the element whose data is to be retrieved
    let clickedElement = $(this);
    let x = getDataAttributes(clickedElement);
});

//=> Bolik
$("form#formEx").submit(function (e) {
    //formEx = form id
    e.preventDefault();
});

//=> knflaper
const func = async () => {
    const result = await swalWithBootstrapButtons.fire({
        title: "Are you sure you want to proceed?",
        icon: "warning",
        showCancelButton: true,
        confirmButtonText: "Yes",
        cancelButtonText: "No",
        reverseButtons: true,
    });
};

//=> fndjslax
$("form#formEx").submit(function (e) {
    //formEx = form id
    e.preventDefault();
    let formData = new FormData(this);
    let objectData = {
        a: "a",
        b: 1,
        c: true,
    };
    sendPostRequest(
        url, // ../Home/IndexJson
        data, //or objectData
        isForm, //if formData send true, if onjectData send false
        this, // this not need for object but send will not be used
        successMessage,
        errorMessage,
        acceptAlert, //want to accept alert true or false
        checkValidation, //check validation for form true or false
        redirectUrl // redirect url if want to reload page send . or send "../Home/Index"
    );
});

//=> fndjslax
$("form#formEx").submit(async function (e) {
    //formEx = form id
    //resp= response from controller with async function
    e.preventDefault();
    let formData = new FormData(this);
    let objectData = {
        a: "a",
        b: 1,
        c: true,
    };
    var resp = sendPostRequest(
        url, // ../Home/IndexJson
        data, //or objectData
        isForm, //if formData send true, if onjectData send false
        this, // this not need for object but send will not be used
        successMessage,
        errorMessage,
        acceptAlert, //want to accept alert true or false
        checkValidation, //check validation for form true or false
        redirectUrl // redirect url if want to reload page send . or send "../Home/Index"
    );
});

//=> sndksfi
let otherFormData = new FormData();
$("form#formEx").submit(function (e) {
    //formEx = form id
    e.preventDefault();
    let formData = new FormData(this);//or any other formData
    let resultForm = new FormData(mergeTwoFormData(formData, otherFormData));
});

//=> nsowrnzsd
let strRandom = randomStringGenerator(10); //send length want to random string length
