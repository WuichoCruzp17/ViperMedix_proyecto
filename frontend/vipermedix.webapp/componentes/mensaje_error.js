import React, {Component} from 'react';
import {Modal, Button} from 'react-bootstrap';
class MensajeError extends Component{

   constructor(props){
    super(props);
    
    this.state ={
        titulo:'',
        descripcion:'',
        open:false,
        close:true ,
        button_visible:true  
    };
   } 
    
    

}

export default MensajeError;