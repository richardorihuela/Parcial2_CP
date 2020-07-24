
package com.mycompany.webservices;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the com.mycompany.webservices package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _AlumnoDB_QNAME = new QName("http://webservices.mycompany.com/", "alumnoDB");
    private final static QName _Alumno1_QNAME = new QName("http://webservices.mycompany.com/", "alumno_1");
    private final static QName _AlumnoDBResponse_QNAME = new QName("http://webservices.mycompany.com/", "alumnoDBResponse");
    private final static QName _Alumno1Response_QNAME = new QName("http://webservices.mycompany.com/", "alumno_1Response");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: com.mycompany.webservices
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link AlumnoDBResponse }
     * 
     */
    public AlumnoDBResponse createAlumnoDBResponse() {
        return new AlumnoDBResponse();
    }

    /**
     * Create an instance of {@link Alumno1Response }
     * 
     */
    public Alumno1Response createAlumno1Response() {
        return new Alumno1Response();
    }

    /**
     * Create an instance of {@link Alumno1 }
     * 
     */
    public Alumno1 createAlumno1() {
        return new Alumno1();
    }

    /**
     * Create an instance of {@link AlumnoDB }
     * 
     */
    public AlumnoDB createAlumnoDB() {
        return new AlumnoDB();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link AlumnoDB }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://webservices.mycompany.com/", name = "alumnoDB")
    public JAXBElement<AlumnoDB> createAlumnoDB(AlumnoDB value) {
        return new JAXBElement<AlumnoDB>(_AlumnoDB_QNAME, AlumnoDB.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Alumno1 }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://webservices.mycompany.com/", name = "alumno_1")
    public JAXBElement<Alumno1> createAlumno1(Alumno1 value) {
        return new JAXBElement<Alumno1>(_Alumno1_QNAME, Alumno1 .class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link AlumnoDBResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://webservices.mycompany.com/", name = "alumnoDBResponse")
    public JAXBElement<AlumnoDBResponse> createAlumnoDBResponse(AlumnoDBResponse value) {
        return new JAXBElement<AlumnoDBResponse>(_AlumnoDBResponse_QNAME, AlumnoDBResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Alumno1Response }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://webservices.mycompany.com/", name = "alumno_1Response")
    public JAXBElement<Alumno1Response> createAlumno1Response(Alumno1Response value) {
        return new JAXBElement<Alumno1Response>(_Alumno1Response_QNAME, Alumno1Response.class, null, value);
    }

}
