function AllToSelected(elem) {
    var list = elem.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode,
    availableList = list.getElementsByClassName("available")[0],
    selectedList = list.getElementsByClassName("selected")[0],
    children = availableList.children,
    i,
    option;

    for (i = 0; i < children.length; i++) {
        option = document.createElement('li');
        option.innerHTML = children[i].innerHTML;
        option.onclick = children[i].onclick;
        option.className = children[i].className;
        option.id = children[i].id;
        selectedList.appendChild(option);
    }

    availableList.innerHTML = "";
}

function AllToAvailable(elem) {
    var list = elem.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode,
    availableList = list.getElementsByClassName("available")[0],
    selectedList = list.getElementsByClassName("selected")[0],
    children = selectedList.children,
    i,
    option;

    for (i = 0; i < children.length; i++) {
        option = document.createElement('li');
        option.innerHTML = children[i].innerHTML;
        option.onclick = children[i].onclick;
        option.className = children[i].className;
        option.id = children[i].id;
        availableList.appendChild(option);
    }

    selectedList.innerHTML = "";
}

function ToSelected(elem) {
    var list = elem.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode,
    availableList = list.getElementsByClassName("available")[0],
    selectedList = list.getElementsByClassName("selected")[0],

    marked = false,

    children = availableList.children;

    for (var i = 0; i < children.length; i++) {

        if (children[i].className.indexOf("marked") > -1) {
            children[i].className = children[i].className.replace(/(?:^|\s)marked(?!\S)/, '');
            selectedList.appendChild(children[i]);
            marked = true;
            i--;
        }
    }

    if (!marked) {
        alert("Nothing selected");
    }
}

function ToAvailable(elem) {
    var list = elem.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode,
    availableList = list.getElementsByClassName("available")[0],
    selectedList = list.getElementsByClassName("selected")[0],

    marked = false,
    children = selectedList.children,
    i;

    for (i = 0; i < children.length; i++) {

        if (children[i].className.indexOf("marked") > -1) {
            children[i].className = children[i].className.replace(/(?:^|\s)marked(?!\S)/, '');
            availableList.appendChild(children[i]);
            marked = true;
            i--;
        }
    }

    if (!marked) {
        alert("Nothing selected");
    }
}

function Mark(elem) {

    if (elem.className == null) {
        elem.className = "marked";
    }
    else
        if (elem.className.indexOf("marked") === -1) {
            elem.className += " marked";
        }
        else {
            elem.className = elem.className.replace(/(?:^|\s)marked(?!\S)/, '');
        }
}