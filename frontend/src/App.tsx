import React, { useEffect } from 'react';
import { Provider, useDispatch } from 'react-redux';
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
