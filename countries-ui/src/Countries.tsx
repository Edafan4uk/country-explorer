import { Container, Table } from 'react-bootstrap';
import ButtonLink from './ButtonLink';
import axios from 'axios';
import { useState, useEffect } from 'react';
import { formatStrings } from './Utils';
import { Country } from './Country';

function Countries() {
  const [countries, setCountries] = useState<Country[]>([]);

  useEffect(() => {
    axios.get<Country[]>('https://localhost:7265/api/countries')
      .then(response => {
        setCountries(response.data);
      })
      .catch(error => {
        console.error(error);
      });
  }, []);
  return (
    <Container>
      <h1>REST COUNTRIES</h1>
      
      <Table responsive>
        <thead>
          <tr>
            <th>Name</th>
            <th>Capital</th>
            <th>Currencies</th>
            <th>Languages</th>
            <th>Region</th>
          </tr>
        </thead>
        <tbody>
          {countries.map((country) => {
            return (
              <tr key={country.name}>
                <td><ButtonLink variant="link" className="mr-1" to={"/countries/" + country.name}>{country.name}</ButtonLink></td>
                <td>{country.capital}</td>
                <td>{formatStrings(country.currencies)}</td>
                <td>{formatStrings(country.languages)}</td>
                <td>{country.region}</td>
              </tr>
            );
          })}
        </tbody>
      </Table>
      
    </Container>
  );
}

export default Countries;
