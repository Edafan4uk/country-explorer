import Container from 'react-bootstrap/Container';
import ButtonLink from './ButtonLink';
import { useParams } from 'react-router-dom';
import { Country } from './Country';
import { useEffect, useState } from 'react';
import axios from 'axios';
import { formatStrings } from './Utils';

function CountryOverview() {
  const { countryName } = useParams();
  const [country, setCountry] = useState<Country>();
  useEffect(() => {
    const url = process.env.REACT_APP_API_URL + `api/countries/${countryName}`;
    axios.get<Country>(url)
      .then(response => {
        setCountry(response.data);
      })
      .catch(error => {
        console.error(error);
      });
  }, [countryName]);
  return (
    <Container>
      <div className="countries-button">
        <ButtonLink to="/" variant="link" className="mr-1">
          Go to Countries Page
        </ButtonLink>
      </div>

      <div id="country">
        <div>
          <img
            alt={country?.alt}
            key={country?.flag}
            src={country?.flag}
          />
        </div>

        <div>
          <h1>
            {country?.name ? (<> {country?.name} </>) : (<i>No Name</i>)}{" "}
          </h1>
          {country?.capital && <p>Capital: {country.capital}</p>}
          {country?.currencies && <p>Currencies: {formatStrings(country.currencies)}</p>}
          {country?.languages && <p>Languages: {formatStrings(country.languages)}</p>}
          {country?.region && <p>Region: {country.region}</p>}
          {country?.googleMaps && (
            <p>
              <a
                target="_blank"
                rel="noreferrer"
                href={country.googleMaps}
              >
                View on Google Maps
              </a>
            </p>
          )}




        </div>
      </div>
    </Container>
  );
}

export default CountryOverview;
