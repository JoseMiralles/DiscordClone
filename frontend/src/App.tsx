import React from 'react';
import { Provider } from 'react-redux';
import './App.css';
import { AuthManager } from './Components/session/AuthManager';
import { configureStore } from './store';

function App() {

  const store = configureStore();

  return (
    <Provider store={store}>
      <AuthManager>
        <h1>Helllooo</h1>
      </AuthManager>
    </Provider>
  );
}

export default App;
