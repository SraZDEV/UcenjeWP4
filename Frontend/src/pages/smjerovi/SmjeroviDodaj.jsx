import { Button, Col, Container, Form, Row } from "react-bootstrap";
import { Link } from "react-router-dom";
import { RoutesNames } from "../../constants";



export default function SmjeroviPregled(){





    return(
        <Container>
            Dodavanje novog smjera
            
            <Form>
                <Form.Group controlId="naziv">
                    <Form.Label>Naziv</Form.Label>
                    <Form.Control type="text" name="naziv" required />
                </Form.Group>

                <Form.Group controlId="trajanje">
                    <Form.Label>Trajanje</Form.Label>
                    <Form.Control type="number" name="trajanje" required min={0} max={2000}/>
                </Form.Group>

                <Form.Group controlId="cijena">
                    <Form.Label>Cijena</Form.Label>
                    <Form.Control type="number" name="cijena" required min={0} max={2000} />
                </Form.Group>

                <Form.Group controlId="izvodiSeOd">
                    <Form.Label>Izvodi Se Od</Form.Label>
                    <Form.Control type="date" name="izvodiSeOd" required />
                </Form.Group>

                <Form.Group controlId="vaucer">
                    <Form.Check label="Vaučer" name="vaucer" />
                </Form.Group>
                <hr />
                <Row>
                    <Col xs={6} sm={6} md={3} lg={6} xl={6} xxl={6}>
                    <Link to = {RoutesNames.SMJER_PREGLED}
                    className="btn btn.danger siroko">
                        Odustani
                    </Link>
                    </Col>
                    <Col xs={6} sm={6} md={9} lg={6} xl={6} xxl={6}>
                    <Button variant="primary" type="submit" className="siroko">
                        Dodaj novi smjer
                    </Button>
                    </Col>
                </Row>
            </Form>
        </Container>
    )
}