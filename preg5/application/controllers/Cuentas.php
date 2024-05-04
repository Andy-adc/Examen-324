<?php
class Cuentas extends CI_Controller {

    public function __construct() {
        parent::__construct();
        $this->load->model('CuentaBancariaModel');
        $this->load->helper('url');  // Carga el helper URL aquí
    }

    public function index() {
        $data['cuentas'] = $this->CuentaBancariaModel->getCuentas();
        $this->load->view('listado_cuentas', $data);
    }

    public function delete($id_cuenta) {
        $this->CuentaBancariaModel->deleteCuenta($id_cuenta);
        redirect('cuentas');
    }
}
