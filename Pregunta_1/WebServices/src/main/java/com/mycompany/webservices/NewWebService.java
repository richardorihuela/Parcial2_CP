/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.webservices;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;

/**
 *
 * @author Pi
 */
@WebService(serviceName = "NewWebService")
public class NewWebService {

    /**
     * Web service operation
     */
    @WebMethod(operationName = "alumno_1")
    @RequestWrapper(className = "com.alumno_1")
    @ResponseWrapper(className = "com.alumno_1Response")
    public List<String> alumno(@WebParam(name = "ci") int ci) {
        List<String> datos = new ArrayList<String>();
        switch(ci){
            case 9064877:
                datos.add("Orihuela");
                datos.add("Gil");
                datos.add("Richard");
                datos.add("67142884");
                return datos;
            default:
                datos.add("");
                datos.add("");
                datos.add("");
                datos.add("");
                return datos;
        }
    }
       
    @WebMethod(operationName = "alumnoDB")
    public List<String> alumnoDB(@WebParam(name = "ci") int ci) {
        try { 
            Class.forName("org.postgresql.Driver");
            System.out.println("Conexion exitosa de DB");
        } catch (ClassNotFoundException ex) {
            System.out.println("Error al registrar el driver de PostgreSQL: " + ex);
        }
        
        Connection BaseDatos = null;
        Statement st = null;
        List<String> datos = new ArrayList<String>();
        
        String url="jdbc:postgresql://localhost:5432/alumno";
        String usuario="postgres";
        String contrasena="123456";

        try {
            //Conexion con la base de datos
            BaseDatos = DriverManager.getConnection(url, usuario, contrasena);
            // Se hara una consulta  de la tabla CDS y Cantante, y se mandara a imprimir.
            System.out.println("Acceso a DB correcto");
            st = BaseDatos.createStatement();
            ResultSet rs = st.executeQuery("SELECT ci, nombre, paterno, materno, telefono FROM estudiante WHERE ci=" + ci);
            while(rs.next()){
                datos.add(rs.getString("ci"));
                datos.add(rs.getString("nombre"));
                datos.add(rs.getString("paterno"));
                datos.add(rs.getString("materno"));
                datos.add(rs.getString("telefono"));
            }
            rs.close();
            st.close();
            BaseDatos.close();
        } catch (Exception e) {
            System.err.println( e.getMessage() );
        }
        return datos;
    }
}
