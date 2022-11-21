import './App.css';
import '../node_modules/bootstrap/dist/css/bootstrap.css'
import Site from './components/pages/Site';
import Pump from './components/pages/Pump';
import Receipt from './components/pages/Receipt';
import Navbar from './components/layout/Navbar';
import { BrowserRouter, Route } from 'react-router-dom';
import { Routes } from 'react-router-dom';


function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <Navbar />
        <Routes>
          <Route exact path="/" element={<Site />} />
          <Route exact path="/pump" element={<Pump />} />
          <Route exact path="/receipt" element={<Receipt />} />
        </Routes>
      </div>
    </BrowserRouter>
  );
};

export default App;
