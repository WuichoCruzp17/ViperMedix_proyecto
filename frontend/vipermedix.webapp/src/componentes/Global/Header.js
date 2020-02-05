//Dependencies
import React, {Component} from 'react';

//Components
import {Navbar, Nav} from 'react-bootstrap';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faThermometerThreeQuarters } from '@fortawesome/free-solid-svg-icons';

//assts
import logo_farmacia from '../../assets/img/LOGOTIPO_FCIA_CASTILLO.png';
import '../../assets/css/header.css';
class Hedare extends Component{


    render(){

        return(
            <Navbar expand="lg" variant="light" bg="light">
                    <Navbar.Brand href="/">
                        <img src={logo_farmacia} className="d-inline-block align-top" width="30%" height="20%"></img>
                    </Navbar.Brand>
            </Navbar>
        );

    }

}

export  default Hedare;