create table public.users (
  id bigint generated always as identity primary key,
  username text not null,
  email text not null,
  password_hash text,
  is_writer boolean default true,
  deleted_at timestamptz,
  created_at timestamptz not null default now()
);

create table public.documents (
  id bigint generated always as identity primary key,
  title text not null,
  owner_id bigint references public.users(id),
  is_published boolean default false,
  content_json jsonb, -- Stores the pages and headings
  deleted_at timestamptz,
  created_at timestamptz not null default now()
);

create table public.document_links (
  id bigint generated always as identity primary key,
  source_document_id bigint references public.documents(id),
  target_document_id bigint references public.documents(id),
  is_private boolean default true,
  deleted_at timestamptz
);

create table public.reviews (
  id bigint generated always as identity primary key,
  user_id bigint references public.users(id),
  rating int check (rating >= 1 and rating <= 5),
  comment text,
  deleted_at timestamptz,
  created_at timestamptz not null default now()
);