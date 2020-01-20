//Dependencies
import React, {Component} from 'react';

//Utils
import  {almacen, global} from '../../utils/propertis';

//Imgs
import def from '../../assets/img/default.PNG';

//Components
import GroupBox from '../Global/Groupbox';

class Almacen extends Component{

    render(){
        return(
            
        <React.Fragment>
            <div className="row">
                <div className="col-sm-12">
                 <GroupBox legend="Busqueda Por:" conten={
                <div>
                    <div className="row">
                        <div className="col-sm-2 text-uppercase">{almacen.key_sucu}:</div>
                            <div className="col-sm-6">
                                <select className="form-control"></select>
                            </div>
                        </div>
                    <div className="row" style={{marginTop:'10px'}}>
                        <di className="col-sm-2 text-uppercase">{almacen.key_codiB}:</di>
                            <div className="col-sm-6">
                                <input type="text" className="form-control"/>
                            </div>
                            <div className="col-sm-2">
                                <button type="button" className="btn btn-success" >{global.key_bus}</button>
                            </div>
                    </div>
                </div>        
                }>
                 </GroupBox>
                </div>
            </div>
            <div className="row">
                <div className="col-sm-12">
                <GroupBox legend="Datos del Producto:" conten={
                    <div className="row">
                       <div className="col-sm-12">
                            <div className="row">
                                <div className="col-sm-6">
                                    <div className="row">
                                        <div className="col-sm-4 text-uppercase">
                                           {almacen.key_susA}:
                                        </div>
                                        <div className="col-sm-7">
                                            <textarea className="form-control"></textarea>
                                        </div>
                                        <div className="col-sm-4 text-uppercase" style={{marginTop:'10px'}}>
                                           {almacen.key_desc}:
                                        </div>
                                        <div className="col-sm-7" style={{marginTop:'10px'}}>
                                            <textarea className="form-control"></textarea>
                                        </div>
                                        <div className="col-sm-12 text-uppercase" style={{marginTop:'10px'}}>
                                           <div className="row">
                                              <div className="col-sm-4">
                                                {almacen.key_preC}:
                                              </div>
                                              <div className="col-sm-5">
                                                <input type="text" className="form-control"></input>
                                              </div> 
                                           </div>
                                        </div>
                                        <div className="col-sm-12">
                                            <div className="row">
                                                <div className="col-sm-4 text-uppercase" style={{marginTop:'10px'}}>
                                                    {almacen.key_preP}:
                                                </div>
                                                <div className="col-sm-5" style={{marginTop:'10px'}}>
                                                    <input type="text" className="form-control" disabled></input>
                                                </div>
                                            </div>
                                        </div>
                                        <div className="col-sm-4 text-uppercase" style={{marginTop:'10px'}}>
                                            {almacen.key_ubi}
                                        </div>
                                        <div className="col-sm-7" style={{marginTop:'10px'}}>
                                            <input type="text" className="form-control"></input>
                                        </div>
                                        <div className="col-sm-4 text-uppercase" style={{marginTop:'10px'}}>
                                            {almacen.key_pro}
                                        </div>
                                        <div className="col-sm-7" style={{marginTop:'10px'}}>
                                            <select className="form-control"></select>
                                        </div>
                                        <div className="col-sm-12">
                                            <div className="row">
                                                <div className="col-sm-3 offset-sm-4">
                                                    <div className="form-check form-check-inline">
                                                        <input type="checkbox" className="form-check-input" ></input>
                                                        <label className="form-check-label text-uppercase">{almacen.key_cad}</label>
                                                    </div>
                                                </div>
                                                <div className="col-sm-3 offset-sm-1">
                                                    <div className="form-check form-check-inline">
                                                        <input type="checkbox" className="form-check-input" ></input>
                                                        <label className="form-check-label text-uppercase">{almacen.key_anti}</label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div> 
                                <div className="col-sm-6">
                                    <div className="text-center">
                                        <img src={def} className="img-fluid"  style={{height:'200px', width:'70%'}}></img>
                                    </div>
                                    <div className="row">
                                        <div className="col-sm-12">
                                            <div className="row">
                                                <div className="col-sm-4 offset-sm-1">
                                                    <div className="row">
                                                        <div className="col-sm-12 text-uppercase">
                                                            {almacen.key_stckA}
                                                        </div>
                                                        <div className="col-sm-12">
                                                            <input type="text" className="form-control" disabled></input>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div className="col-sm-4 offset-sm-2">
                                                    <div className="row">
                                                        <div className="col-sm-12 text-uppercase">
                                                            {almacen.key_cantAd}
                                                        </div>
                                                        <div className="col-sm-12">
                                                            <input type="text" className="form-control"></input>
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
                }></GroupBox>
                </div>
            </div>
            <div className="row" style={{marginBottom:'20px'}}>
                <div className="col-sm-4 offset-sm-2">
                    <button type="button" className="btn btn-success" style={{width:'100%',marginTop:'10px'}}>{almacen.key_agIn}</button>
                </div>
                <div className="col-sm-4">
                     <button type="button" className="btn btn-primary" style={{width:'100%',marginTop:'10px'}}>{global.key_limp}</button>
                </div>
            </div>
        </React.Fragment>   
        )
    };
      

}

export default Almacen;