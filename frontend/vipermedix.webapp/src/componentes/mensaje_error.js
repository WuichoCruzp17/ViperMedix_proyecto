import React, {Component} from 'react';
import {Modal} from 'react-bootstrap';
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
    
    render(){
        return(
            <Modal.Dialog>
                <Modal.Body>
                    
                </Modal.Body>
            </Modal.Dialog>
        );
    }

}

export default MensajeError;