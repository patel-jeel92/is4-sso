import axios from "axios";

async function getWeatherFromApi(accessToken) {
  axios.defaults.headers.common["Authorization"] = `Bearer ${accessToken}`;
  const response = await axios.get("http://localhost:6001/weather");
  return response.data;
}

export { getWeatherFromApi };
