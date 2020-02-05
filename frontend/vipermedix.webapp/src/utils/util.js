const formUtil ={
    printForm(formName,model){
        var elements =  document.querySelectorAll('form[name="'+formName+'"] input, text-area, select, textarea');
        console.log(elements);
        if(elements !==null){
            for(var i=0;i<elements.length;i++){
                document.getElementsByName(elements[i].name)[0].value =model[elements[i].name];
            }
        }
    }
}

module.exports = {formUtil};