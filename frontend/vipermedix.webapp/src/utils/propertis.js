
const inventario ={
    key_tit:'Almacen',
    key_sucu:'Sucursal',
    key_codiB:'Codigo de Barras',
    key_susA:'Sustancia Activa',
    key_desc:'Descripción',
    key_preC:'Precio de Costo',
    key_preP:'Precio Publico',
    key_ubi:'Ubicación',
    key_pro:'Proveedor',
    key_stckA:'Stock Actual',
    key_cantAd:'Cantidad Adquirida',
    key_cad:'Caducidad',
    key_anti:'Antibiotico',
    key_agIn:'Agregar Inventario',
    key_titM:'Control de Caducidades',
    key_subtM:'Favor de Ingresar el #Lote, Stock y la Caducidad \n Correspondientes',
    key_numLoM:'Numero de Lote',
    key_cantM:'Cantidad',
    key_cadM:'Caducidad',
    frm_name:'inventario',
    frm_sucu:'sucursal',
    frm_codiB:'barCode',
    frm_susA:'activeSubstanceId',
    frm_desc:'description',
    frm_preC:'InvMax',
    frm_preP:'standardCost',
    frm_ubi:'ubicacion',
    frm_stckA:'stock_actual',
    frm_cantAd:'cantidad_adquirida',
    frm_pro:'proveedor',
    frm_cadM:'caducidad',
    frm_anti:'antibiotico',
    frm_cad:'caducidad'

};

const global ={
    key_bus:'Buscar',
    key_limp:'Limpiar',
    key_acep:'Aceptar',
    key_canc:'Cancelar'
};

const login ={
    key_emp:'Empresa',
    key_user:'Usuario',
    key_pass:'Contraseña',
    key_iniS:'Iniciar   Sesion'
};

const service={
    path:"https://localhost:5001"
};

module.exports = {inventario,global, login, service}
