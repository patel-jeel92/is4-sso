import * as apiService from "../services/apiService";

import React, { useState } from "react";

import { prettifyJson } from "../utils/jsonUtils";
import { signoutRedirect } from "../services/userService";
import { useSelector } from "react-redux";

function Home() {
  const user = useSelector((state) => state.auth.user);
  const [weatherData, setWeatherData] = useState(null);
  function signOut() {
    signoutRedirect();
  }

  async function getWeather() {
    const weather = await apiService.getWeatherFromApi(user.access_token);
    setWeatherData(weather);
  }

  return (
    <div>
      <h1>Home</h1>
      <p>Hello, {user.profile.given_name}.</p>
      <p>I have given you a token to call the weather forecast api</p>

      <p>
        💡 <strong>Tip: </strong>
        <em>
          Use the Redux dev tools and network tab to inspect what user data was
          returned from identity and stored in the client.
        </em>
      </p>

      <button className="button button-outline" onClick={() => getWeather()}>
        Get Weather
      </button>
      <button className="button button-clear" onClick={() => signOut()}>
        Sign Out
      </button>

      <pre>
        <code>
          {prettifyJson(weatherData ? weatherData : "No forecast yet :(")}
        </code>
      </pre>
      <p>
        <a
          target="_blank"
          rel="noopener noreferrer"
          href=""
        >
          GitLab Repo
        </a>
      </p>
    </div>
  );
}

export default Home;
