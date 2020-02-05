//Dependencies
import React, {Component} from 'react';

//Components
import {InputGroup, FormControl, Button} from 'react-bootstrap';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHospital, faUserCircle,  faUnlock } from '@fortawesome/free-solid-svg-icons';
//Utils
import {login} from  '../utils/propertis';

//assets
import '../assets/css/login.css';
import logo from '../assets/img/Logotipo OwalTek.jpg';

class Login extends Component {

    render(){
        return(
            <div className="container">
                <div class="row">
                    <div className="col-md-12 min-vh-100 d-flex flex-column justify-content-center">
                        <div className="row">
                            <div className="col-lg-6 col-md-8 mx-auto">
                                <div className="card">
                                <div className="card-header">
                                    <div className="row">
                                        <div className="col-4 bod-r">
                                            <img src={logo} className="img-fluid"/>
                                        </div>
                                        <div className="col-8">
                                            <h1 className="txt-tit-log">Sistemas Owaltek</h1>
                                        </div>
                                    </div>
                                </div>
                                <div className="card-body">
                                    <div className="row">
                                        <div className="col-sm-10 offset-sm-1">
                                            <InputGroup>
                                                <InputGroup.Prepend>
                                                    <InputGroup.Text><FontAwesomeIcon icon={faHospital}></FontAwesomeIcon></InputGroup.Text>
                                                </InputGroup.Prepend>
                                                <FormControl placeholder={login.key_emp}/>
                                            </InputGroup>
                                        </div>
                                        <div className="col-sm-10 offset-sm-1 mtop-10">
                                            <InputGroup>
                                                <InputGroup.Prepend>
                                                    <InputGroup.Text><FontAwesomeIcon icon={faUserCircle}></FontAwesomeIcon></InputGroup.Text>
                                                </InputGroup.Prepend>
                                                <FormControl placeholder={login.key_user}/>
                                            </InputGroup>
                                        </div>
                                        <div className="col-sm-10 offset-sm-1 mtop-10">
                                            <InputGroup>
                                                <InputGroup.Prepend>
                                                    <InputGroup.Text><FontAwesomeIcon icon={faUnlock}></FontAwesomeIcon></InputGroup.Text>
                                                </InputGroup.Prepend>
                                                <FormControl placeholder={login.key_pass}/>
                                            </InputGroup>
                                        </div>
                                        <div className="col-xl-4 offset-xl-4  col-lg-6  offset-lg-3  col-sm-10 offset-sm-1  mtop-10">
                                            <div className="d-flex flex-column">
                                                <Button variant="primary">{login.key_iniS}</Button>
                                            </div>
                                            
                                        </div>
                                    </div>
                                </div>
                            </div>
                            </div>
                        </div>
                            
                    </div>
                   
                </div>
            </div>
        );
    }

}

export default Login;