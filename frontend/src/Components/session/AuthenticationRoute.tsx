import { Redirect, Route, RouteProps } from 'react-router';

export type AuthenticationRouteProps = {
  isAuthenticated: boolean;
  redirectTo: string;
} & RouteProps;

export default function AuthenticationRoute({isAuthenticated, redirectTo, ...routeProps}: AuthenticationRouteProps) {
  if(!isAuthenticated) {
    return <Route {...routeProps} />;
  } else {
    return <Redirect to={{ pathname: redirectTo }} />;
  }
};