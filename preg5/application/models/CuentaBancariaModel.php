<?php
class CuentaBancariaModel extends CI_Model {
    public function __construct() {
        parent::__construct();
        $this->load->database();
    }

    public function getCuentas() {
        $query = $this->db->get('cuenta_bancaria');
        return $query->result();
    }

    public function deleteCuenta($id_cuenta) {
        $this->db->where('id_cuenta', $id_cuenta);
        $this->db->delete('cuenta_bancaria');
    }
}
?>