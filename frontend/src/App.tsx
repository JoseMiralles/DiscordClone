import React from 'react';
import { Provider } from 'react-redux';
import './App.css';
import { configureStore } from './store';

function App() {

  const store = configureStore();

  return (
    <Provider store={ store }>
      <div className="App">
        <header className="App-header">
        </header>
      </div>
    </Provider>
  );
}

export default App;
