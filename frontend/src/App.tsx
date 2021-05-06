import React from 'react';
import { useSelector } from 'react-redux';
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import Header from './Components/Header';
import { AuthManager } from './Components/session/AuthManager';
import ProtectedRoute from './Components/session/ProtectedRoute';
import AuthenticationRoute from "./Components/session/AuthenticationRoute";
import { AppState } from './store';
import LoginPage from './Components/session/LoginPage';
import RegisterPage from './Components/session/RegisterPage';

function App() {
  
  const { userId, restoringSession } = useSelector((s: AppState) => s.session);
  const isAuthenticated = userId ? true : false;
  
  return (
    <AuthManager>
      <Router>

        <Header isAuthenticated={isAuthenticated}/>
        
        <Switch>
          <ProtectedRoute path="/s" authenticationPath="/login"
            component={()=>(<h1>test</h1>)}
            isAuthenticated={isAuthenticated || restoringSession} />
          
          <AuthenticationRoute path="/register" redirectTo="/home"
            component={RegisterPage}
            isAuthenticated={isAuthenticated} />
          <AuthenticationRoute path="/login" redirectTo="/home"
            component={LoginPage}
            isAuthenticated={isAuthenticated} />
        </Switch>

      </Router>
    </AuthManager>
  );
}

export default App;
