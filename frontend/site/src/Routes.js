import React from 'react';
import {BrowserRouter,Switch,Route} from 'react-router-dom';

import Home from './pages/Home';
import Cadastrar from './pages/Cadastrar';
import Consultar from './pages/Consultar';
import Alterar from './pages/alterar';

function Rotas(){
    return(
         
    <BrowserRouter>
      <Switch>
          <Route path="/" exact component={Home}/>
          <Route path="/cadastrar" component={Cadastrar}/>
          <Route path="/consultar" component={Consultar}/>
          <Route path="/alterar/:id" component={Alterar}/>
       </Switch>
      </BrowserRouter>

    );
}
export default Rotas;