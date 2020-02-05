import React, {Component} from 'react';

//assets
import '../assets/css/modalforms.css';

//Components
import {Modal} from 'react-bootstrap';

class ModalForms extends Component{

    render(){
        return(  
            <Modal show={this.props.show} onHide={this.props.handleClose} aria-labelledby="contained-modal-title-vcenter"
            centered size="lg">
                    <Modal.Body>
                        {this.props.conten}
                    </Modal.Body>
                    <div className=".mf-footer">
                        {this.props.content_body}
                    </div>
            </Modal>
        );
    }

}

export default ModalForms;