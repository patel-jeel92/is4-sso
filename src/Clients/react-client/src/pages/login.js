import React from "react";
import { Redirect } from "react-router-dom";
import { signinRedirect } from "../services/userService";
import { useSelector } from "react-redux";

function Login() {
  const user = useSelector((state) => state.auth.user);

  function login() {
    signinRedirect();
  }

  return user ? (
    <Redirect to={"/"} />
  ) : (
    <div>
      <h1>Hello!</h1>
      <p>Welcome to WWF (We Want the Forecast).</p>
      <p>
        A demo of using React and Identity Server 4 to authenticate a user via
        OpenID Connect to gain access to a web API (and some weather forecast).
      </p>
      <p>Start by signing in.</p>
      <p>
        💡 <strong>Tip: </strong>
        <em>User: 'alice', Pass: 'My long 123$ password'</em>
      </p>

      <button onClick={() => login()}>Login</button>
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

export default Login;
