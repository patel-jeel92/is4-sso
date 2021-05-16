import { UserManager } from "oidc-client";
import { storeUserError, storeUser } from "../actions/authActions";

const config = {
  authority: "https://localhost:5000",
  client_id: "js",
  client_secret: "secret",
  redirect_uri: "http://localhost:3000/signin-oidc",
  response_type: "code",
  scope: "openid profile web_api",
};

const userManager = new UserManager(config);

export async function loadUserFromStorage(store) {
  try {
    let user = await userManager.getUser();
    if (!user) {
      return store.dispatch(storeUserError());
    }
    store.dispatch(storeUser(user));
  } catch (e) {
    console.error(`User not found: ${e}`);
    store.dispatch(storeUserError());
  }
}

export function signinRedirect() {
  return userManager.signinRedirect();
}

export function signinRedirectCallback() {
  return userManager.signinRedirectCallback();
}

export async function signoutRedirect() {
  let user = await userManager.getUser();
  userManager.clearStaleState();
  userManager.removeUser();
  return userManager.signoutRedirect({ id_token_hint: user.id_token });
}

export function signoutRedirectCallback() {
  userManager.clearStaleState();
  userManager.removeUser();
  return userManager.signoutRedirectCallback();
}

export default userManager;
