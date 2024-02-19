import { BrowserRouter, Routes, Route, Navigate } from 'react-router-dom';
import Countries from './Countries';
import CountryOverview from './CountryOverview';
import './App.css';
import NotFound from './NotFound';
import ErrorPage from './ErrorPage';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Navigate to="/countries" />} />
        <Route path="/countries/:countryName" element={<CountryOverview />} errorElement={<ErrorPage />} />
        <Route path="/countries" element={<Countries />} errorElement={<ErrorPage />} />
        <Route path="*" element={<NotFound />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
