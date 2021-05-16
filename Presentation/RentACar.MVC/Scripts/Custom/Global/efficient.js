//get all data inside a node element Unique => Defne
const getDataAttributes = (node) => {
    let x = {},
        re_dataAttr = /^data\-(.+)$/;

    $.each(node.get(0).attributes, function (index, attr) {

        if (re_dataAttr.test(attr.nodeName)) {
            let key = attr.nodeName.match(re_dataAttr)[1];
            x[key] = attr.nodeValue;
        }
    });
    return x;
};


//checkbox return on or null this func turn checkbox input if on true else false and return FormData object Unique => jkfueosmc
const formCheckBoxToBool = (data, formThis) => {
    let toggles = $(formThis).find('input:checkbox');
    for (i = 0; i < toggles.length; i++) {
        data.set(toggles[i].name, toggles[i].checked)
        //$(formThis).find('input[name="' + toggles[i].name + '"]').val(toggles[i].checked);
    }

    return data;
};


//highlight form input element after submit Unique => Bolik
(function () {
    "use strict";
    window.addEventListener(
        "load",
        function () {
            // Fetch all the forms we want to apply custom Bootstrap validation styles to
            var forms = document.getElementsByClassName("needs-validation");
            // Loop over them and prevent submission
            var validation = Array.prototype.filter.call(forms, function (form) {
                form.addEventListener(
                    "submit",
                    function (event) {
                        if (form.checkValidity() === false) {
                            event.stopPropagation();
                        }
                        event.preventDefault();
                        form.classList.add("was-validated");
                    },
                    false
                );
            });
        },
        false
    );
})();


//created simple yes no button with sweetalert2 Unique => knflaper
const swalWithBootstrapButtons = Swal.mixin({
    customClass: {
        confirmButton: "btn btn-success ml-3",
        cancelButton: "btn btn-danger mr-3",
    },
    buttonsStyling: false,
});


//send a post request form or object Unique => fndjslax
const sendPostRequest = async (
    url, // ../Home/IndexJson
    data, //json or form
    isForm, //true or false
    formThis, // this
    successMessage,
    errorMessage,
    acceptAlert, //accept alert
    checkValidation, //check validation for form
    redirectUrl // redirect url
) => {

    if (isForm && checkValidation) {
        if (!formThis.checkValidity()) {
            return 0;
        }
    }
    if (isForm) {
        data = formCheckBoxToBool(data, formThis);
    }
    if (acceptAlert) {
        //async func must be await
        const result = await swalWithBootstrapButtons.fire({
            title: "Are you sure you want to proceed?",
            icon: "warning",
            showCancelButton: true,
            confirmButtonText: "Yes",
            cancelButtonText: "No",
            reverseButtons: true,
        });
        //result = {isConfirmed, isDenied, isDismissed, value}
        if (!result.isConfirmed) {
            return 0;
        }
        else {
 
 /*await   $("#loadingDiv").show();*/
        }
    }

    let resp = {};
    await showLoading();
  await  $.ajax({
        url,
        async: false,
        type: "POST",
        data: isForm ? data : JSON.stringify(data),
        dataType: "json",
        success: function (response) {
             hideLoading();
            if (response.flag) {
                if (acceptAlert) {
                    debugger;
                    //if added a language pack declare variable inside a cshtml and use this variable
                    if (successMessage == 'service') {

                        Swal.fire({
                            title: response.Data.status + '' + response.Data.errormessage  ,
                            icon: "success",
                        }).then(() => {
                            if (isForm) {
                                $(formThis).trigger("reset");
                            }
                            //not improted result go to redirect
                            window.location.href = redirectUrl;
                        }
                        );
                    } else {
                        Swal.fire({
                            title: successMessage,
                            icon: "success",
                        }).then(() => {
                            if (isForm) {
                                $(formThis).trigger("reset");
                            }
                            //not improted result go to redirect
                            window.location.href = redirectUrl;
                        }
                        );
                    }
                } else
                    window.location.href = redirectUrl;
            } else {
                Swal.fire({
                    title: response.Data.status + '' + response.Data.errormessage,
                    icon: "error",
                });
            }
        },
        error: function (e) {

            if (errorMessage =='service') {
                Swal.fire({
                    title: response.Data.status + '' + response.Data.errormessage,
                    icon: "error",
                });
            } else {
                Swal.fire({
                    title:
                        "Unexpected error, Status Code:" +
                        e.status +
                        " Message:" +
                        e.statusText,
                    icon: "error",
                });
            }
          
        },
        cache: false,
        //if form set false, if object set this "application/json; charset=utf-8"
        contentType: isForm ? false : "application/json; charset=utf-8",
        processData: false,
    });
    return resp;
};



//merged the two formdata returned formData Unique => sndksfi
const mergeTwoFormData = async (formData1, formData2) => {
    for (var f of formData2.entries()) {
        formData1.append(f[0], f[1]);
    }
    return formData1;
};

async function showLoading() {
 await   $("#loadingDiv").show();
}
async function hideLoading() {
   await $("#loadingDiv").hide();
}
//random string generator Unique => nsowrnzsd
const randomStringGenerator = (len) => {
    var length = len ? len : 10;
    var string = "abcdefghijklmnopqrstuvwxyz"; //to upper
    var numeric = "0123456789";
    var password = "";
    var character = "";
    var crunch = true;
    while (password.length < length) {
        entity1 = Math.ceil(string.length * Math.random() * Math.random());
        entity2 = Math.ceil(numeric.length * Math.random() * Math.random());
        hold = string.charAt(entity1);
        hold = password.length % 2 == 0 ? hold.toUpperCase() : hold;
        character += hold;
        character += numeric.charAt(entity2);
        password = character;
    }
    password = password
        .split("")
        .sort(function () {
            return 0.5 - Math.random();
        })
        .join("");
    return password.substr(0, len);
};


//convert to non english char to eng char inside a string word Unique => fnshbfsudx
const convertNonEngToEng = (str) => {
    var maxLength = 100;

    var returnString = str.toLowerCase();
    //Convert Characters
    returnString = returnString.replace(/ö/g, 'o');
    returnString = returnString.replace(/ç/g, 'c');
    returnString = returnString.replace(/ş/g, 's');
    returnString = returnString.replace(/ı/g, 'i');
    returnString = returnString.replace(/ğ/g, 'g');
    returnString = returnString.replace(/ü/g, 'u');

    // if there are other invalid chars, convert them into blank spaces
    returnString = returnString.replace(/[^a-z0-9\s-]/g, "");
    // convert multiple spaces and hyphens into one space       
    returnString = returnString.replace(/[\s-]+/g, " ");
    // trims current string
    returnString = returnString.replace(/^\s+|\s+$/g, "");
    // cuts string (if too long)
    if (returnString.length > maxLength)
        returnString = returnString.substring(0, maxLength);
    // add hyphens
    returnString = returnString.replace(/\s/g, "-");

    return returnString;
}


//timeStamp to Date  Time Value type=1 => withClock(dd/mm/yyyy) type = 2 => withoutClock(dd/MM/yyyy hh:mm:ss) Unique => dyebuzjzuf
const timeStampToDate = (time, type) => {
    let date = new Date(Number(time));
    const day = date.getDate() < 9 ? "0" + date.getDate() : date.getDate();;
    const month = date.getMonth() < 9 ? "0" + (date.getMonth() + 1) : (date.getMonth() + 1);
    const year = date.getFullYear();
    const hour = date.getHours() < 9 ? "0" + date.getHours() : date.getHours();
    const minute = date.getMinutes() < 9 ? "0" + date.getMinutes() : date.getMinutes();
    const second = date.getSeconds() < 9 ? "0" + date.getSeconds() : date.getSeconds();
    const res = day + "/" + month + "/" + year + " " + hour + ":" + minute + ":" + second;
    const resNoClock = day + "/" + month + "/" + year;
    if (type == 1)
        return res;
    if (type == 2)
        return resNoClock;
};


//HTML.Raw to js object fix( datetime for example )
const rawToJs = (objectStr) => {
    var objectConvert = {};
    try {
        objectConvert = JSON.parse(objectStr);

    } catch (e) {
        return objectConvert;
    }
    for (const property in objectConvert) {
        //console.log(`${property}: ${objectConvert[property]}`);
        //datetime control
        if (checkValueIsDate(objectConvert[property])) {
            //clear without number area
            const tmpTime = objectConvert[property].replace(/\D/g, '');
            objectConvert[property] = timeStampToDate(tmpTime, 1);
        }
    }
    return objectConvert;
}


//check value is date Unique => fhudqpriz
const checkValueIsDate = (value) => {
    if (value == null) {
        return false;
    }
    value = value.toString();
    var head = value.startsWith("/Date(");
    var end = value.endsWith(")/");
    if (head && end) {//startwith "/Date(" and end with ")/" and
        var part = lastSubStringTwoChar("(", ")", value);
        if (part.length == 10 || part.length == 13) {
            //if date area 13(with ms timestamp) or 10 (without ms timestamp)
            //if (value.length == 18 || value.length == 21) {
            //    //if(all)
            //    return true;
            //}
            return Number(part).toString() == "NaN" ? false : true;;//if it is a integer return true
        }
    }
    return false;
}


//get a char between two char Unique => hyeirsoxnm
const lastSubStringTwoChar = (first, last, str) => {
    var part = str.substring(
        str.lastIndexOf(first) + 1,
        str.lastIndexOf(last)
    );
    return part;
}


//update modal name fix Unique => husdyjdfA
const updateItemToForm = (obj, formId) => {
    debugger;
    $("form").trigger("reset");

    var allInputs = $("form :input");

    for (let [key, value] of Object.entries(obj)) {
        for (let [keyIn, valueIn] of Object.entries(allInputs)) {
            if (valueIn.name == key) {
                //found item
                switch (valueIn.type) {
                    //select-one
                    //select-multiple
                    //password
                    //text
                    //textarea
                    //checkbox
                    //number
                    //hidden
                    //submit
                    case "select-one":
                        $("select[name='" + key + "'] option[value='" + value + "']").prop("selected", true).change();
                        //$("select").change();
                        break;
                    //case "select-multiple":
                    //    $("select[name='"+key+"'] option[value='" + value + "']").prop("selected", true).change();
                    //    $("select").change();
                    //break;
                    case "text":
                        $('input[name="' + key + '"]').val(value);
                        break;
                    case "textarea":
                        $('input[name="' + key + '"]').val(value);
                        break;
                    case "password":
                        $('input[name="' + key + '"]').val(value);
                        break;
                    case "hidden":
                        $('input[name="' + key + '"]').val(value);
                        break;
                    case "number":
                        $('input[name="' + key + '"]').val(value);
                        break;
                    case "checkbox":
                        $('input[name="' + key + '"]').prop('checked', value).change();
                        break;
                    default:
                        break;
                }

            }
        }
    }
}

