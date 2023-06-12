import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Button, Header, List } from 'semantic-ui-react';

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities')
      .then(response => {
        // console.log(response);
        setActivities(response.data);
      });
  }, []);

  return (
    <div>
       
       <Header as='h2' icon='users' content='Reactivities' />
       <List>
        {activities.map((activity:any) => (
            <List.Item key={activity.id}>
              {activity.title}
            </List.Item>
          ))}
       </List>

       {/* <Button content='Test'/> */}
      
        {/* <img src={logo} className="App-logo" alt="logo" />
        <ul>
          {activities.map((activity:any) => (
            <li key={activity.id}>
              {activity.title}
            </li>
          ))}
        </ul> */}
       
      {/* <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <ul>
          {activities.map((activity:any) => (
            <li key={activity.id}>
              {activity.title}
            </li>
          ))}
        </ul> 
        </header> */}

        {/* <header className="App-header">
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header> */}

    </div>
  );
}

export default App;
