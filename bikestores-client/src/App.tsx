import './App.css';
import axios from 'axios';
import { useState, useEffect } from 'react';
import { brand } from './types/types';
function App() {

  const [data, setData] = useState<brand[]>([]);

  useEffect(() => {
    const fetchData = async () => {
      const response = await axios.get<brand[]>("https://localhost:7150/api/Brand")
      if (!(response.status === 200)) {
        console.error(response.status)
      }
      else {
        setData(response.data)
      }
    }
    fetchData();
  }, [])

  console.log(data);

  return (
    <div className="App">
      Hello World I am here
      {data.map(b => {
        return (
          <div key={b.Id}>
            <div>{b.brandName}</div>
          </div>
        )
      })}
    </div>
  );
}

export default App;
